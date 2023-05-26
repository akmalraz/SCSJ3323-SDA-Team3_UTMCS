using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCSJ3323_SDA_Team3_UTMCS
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (Session["LoggedInUser"] != null)
            {
                // Set the profile picture image URL
                imgProfilePicture.ImageUrl = GetProfilePicture();
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        // Method to retrieve the profile picture path from the session and return the image URL
        protected string GetProfilePicture()
        {
            if (Session["ProfilePicturePath"] != null)
            {
                string profilePicturePath = Session["ProfilePicturePath"].ToString();
                return profilePicturePath;
            }
            else
            {
                // Return a default image URL if the profile picture path is not available
                return "path/to/default/image.jpg";
            }
        }
    }
}