﻿using BLLProject.Interfaces;
using BLLProject.Specification;
using DALProject.model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PLProject.ViewModels.AppointmentViewModel;
using X.PagedList;

namespace PLProject.Controllers
{
    public class AppointmentReceptionistController : Controller
    {
        #region Dpi
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment env;
        private readonly UserManager<AppUser> userManager;
        private string UserId;

        public AppointmentReceptionistController(IUnitOfWork unitOfWork, IWebHostEnvironment Env, UserManager<AppUser> UserManager)
        {
            this.unitOfWork = unitOfWork;
            env = Env;
            userManager = UserManager;
        }
        #endregion

        #region Get all Appointment for Receptionist
        public async Task<IActionResult> IndexAsync(int? page)
        {

            var spec = new BaseSpecification<Apointment>(a => /*&&a.ApointmentDate==DateOnly.FromDateTime(DateTime.Now)*/ a.ApointmentStatus == ApointmentStatusEnum.Scheduled);
            spec.Includes.Add(a => a.Patient);
            spec.Includes.Add(a => a.Doctor);
            spec.Includes.Add(a => a.Clinic);
            
            var appointments = unitOfWork.Repository<Apointment>().GetALLWithSpec(spec).ToList();

            var patientappointments = appointments.Select(app => app.ConvertApointmentToAppointmentGenarelVM());
            // Pagination logic
            int pageSize = 10;
            int pageNumber = page ?? 1;

            var paginatedList = patientappointments.ToPagedList(pageNumber, pageSize);

            return View(paginatedList);
        }

        #endregion

        #region Details
        public IActionResult Details(int? Id, string viewname = "Details")
        {
            if (!Id.HasValue)
                return BadRequest(); // 400
            var spec = new BaseSpecification<Apointment>(a => a.Id == Id);
            spec.Includes.Add(a => a.Patient);
            spec.Includes.Add(a => a.Doctor);
            spec.Includes.Add(a => a.Clinic);
       
            var apointment = unitOfWork.Repository<Apointment>().GetEntityWithSpec(spec);
            var apointmentVM = apointment.ConvertApointmentToAppointmentGenarelVM();

            if (apointmentVM is null)
                return NotFound(); // 404

            return View(viewname, apointmentVM);

        }
        #endregion

        #region Edit
        public IActionResult Edit(int? Id)
        {
            var _user = userManager.GetUserAsync(User).GetAwaiter().GetResult();
            UserId = _user.Id;

            var _receptionist = unitOfWork.Repository<Receptionist>().Get(UserId);

            if (!Id.HasValue)
                return BadRequest(); // 400

            var spec = new BaseSpecification<Apointment>(a => a.Id == Id);
            spec.Includes.Add(a => a.Patient);
            spec.Includes.Add(a => a.Doctor);
            spec.Includes.Add(a => a.Clinic);

            var apointment = unitOfWork.Repository<Apointment>().GetEntityWithSpec(spec);
            var apointmentVM = apointment.ConvertToReceptionAppointmentVM(_receptionist);

            return View(apointmentVM);
        }

        [HttpPost]

        public IActionResult Edit(ReceptionAppiontmentViewModel ViewModel)
        {
            ModelState.Remove<AppointmentGenarelVM>(a => a.Invoice.PaymentType);
            ModelState.Remove<AppointmentGenarelVM>(a => a.Invoice.Apointment);
            ModelState.Remove<AppointmentGenarelVM>(a => a.Invoice.Receptionist);

            if (!ModelState.IsValid)
            {
                return Edit(ViewModel.Id);
            }

            try
            {
                // get the appointment from Repository 
                var apointment = unitOfWork.Repository<Apointment>().Get(ViewModel.Id);
                apointment.FromReceptionToAppointment(ViewModel);

                apointment.ApointmentStatus = ApointmentStatusEnum.Confirmed;
                // Update the appointment in the repository
                unitOfWork.Repository<Apointment>().Update(apointment);
                unitOfWork.Complete();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Handle exceptions and add error messages to the model state
                var errorMessage = env.IsDevelopment() ? ex.Message : "An error occurred during the update.";
                ModelState.AddModelError(string.Empty, errorMessage);

                return View(ViewModel);
            }
        }
        #endregion
    }
}