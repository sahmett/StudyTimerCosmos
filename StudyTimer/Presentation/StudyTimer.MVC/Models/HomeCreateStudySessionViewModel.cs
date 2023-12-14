﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudyTimer.MVC.Models
{
    public class HomeCreateStudySessionViewModel
    {
        public string Topic { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<SelectListItem> TimeOptions { get; set; }
        public int SelectedTime { get; set; }
    }
}
