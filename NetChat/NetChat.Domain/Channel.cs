﻿using System;

namespace NetChat.Domain
{
    public class Channel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
