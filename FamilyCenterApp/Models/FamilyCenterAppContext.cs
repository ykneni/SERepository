﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FamilyCenterApp.Models
{
    public class FamilyCenterAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FamilyCenterAppContext() : base("name=FamilyCenterAppContext")
        {
        }
        public DbSet<RelationshipModel> RelationshipModels { get; set; }
        public DbSet<MessageModel> MessageModels { get; set; }
        public DbSet<CalendarModel> CalendarModels { get; set; }
        public DbSet<GalleryModel> GalleryModels { get; set; }

        
    }
}
