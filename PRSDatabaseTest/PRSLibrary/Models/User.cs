﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRSLibrary.Models {
    public class User {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsReviewer { get; set; } = false;
        public bool IsAdmin { get; set; } = false;

        public virtual List<Request> Requests { get; set; }

        //only for testing purposes
        public override string ToString() {
            return $"{Firstname} is logged in with their username {Username}.";
        }
    }
}
