﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PRSLibrary.Models {
    public class RequestLine {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;

        public virtual Product Product { get; set; }
        public virtual Request Request { get; set; }
    }
}
