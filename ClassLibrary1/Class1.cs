using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassLibrary1
{
    public class Class1:CompositeControl
    {
        Label lbl;
        TextBox TxtBox;
        ImageButton Imgbtn;
        Calendar cal;
        protected override void RecreateChildControls()
        {
            lbl = new Label();
            TxtBox = new TextBox();
            Imgbtn = new ImageButton();
            cal = new Calendar();

            lbl.ID = "l1";
            TxtBox.ID = "t1";
            Imgbtn.ID = "I1";
            cal.ID = "c1";

            lbl.Text = "date";

            this.Controls.Add(lbl);
            this.Controls.Add(TxtBox);
            this.Controls.Add(Imgbtn);
            this.Controls.Add(cal);

        }

        protected override void Render(HtmlTextWriter writer)
        {
            lbl.RenderControl(writer);
            TxtBox.RenderControl(writer);
            Imgbtn.RenderControl(writer);
            cal.RenderControl(writer);

        }
    }
}
