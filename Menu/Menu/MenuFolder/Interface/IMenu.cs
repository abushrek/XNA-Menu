﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Menu.MenuFolder.Classes;

namespace Menu.MenuFolder.Interface
{
    public interface IMenu : IDraw
    {
        Items Selected { get; set; }
        void Next();
        void Before();
        void UpdateItem(string text, int i, string value = "");
    }
}
