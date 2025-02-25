﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIFrameworkMaps.Data.Models.ViewModels.Management
{
    public class LayerEditModel
    {
        public GIFrameworkMaps.Data.Models.Layer? Layer { get; set; }
        public SelectList? AvailableBounds { get; set; }
        public List<int> SelectedCategories { get; set; } = new();
        public List<Category> AvailableCategories { get; set; } = new();
    }
}
