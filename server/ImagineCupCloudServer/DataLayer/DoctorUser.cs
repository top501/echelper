﻿/*
 * echelper, An Open Source Mobile Medical System
 * Copyright (C) 2013, Nicefforts
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DoctorUser
    {
        public String Username { get; set; }

        //public String Password { get; set; }

        public String NickName { get; set; }

        public String Role { get; set; }

        public String Grade { get; set; }

        public String Description { get; set; }

        public String email { get; set; }

        public String phone { get; set; }

        public String Image { get; set; }

        //public bool Online { get; set; }

        public List<string> FollowedList { get; set; }

        public List<string> FollowingList { get; set; }


    }
}