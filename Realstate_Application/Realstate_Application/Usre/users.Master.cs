﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Realstate_Application.Usre
{
    public partial class users : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_booking_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}