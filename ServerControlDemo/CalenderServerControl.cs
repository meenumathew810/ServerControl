using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControlDemo
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:CalenderServerControl runat=server></{0}:CalenderServerControl>")]
    public class CalenderServerControl : CompositeControl
    {
        //[Bindable(true)]
        //[Category("Appearance")]
        //[DefaultValue("")]
        //[Localizable(true)]
        //public string Text
        //{
        //    get
        //    {
        //        String s = (String)ViewState["Text"];
        //        return ((s == null) ? String.Empty : s);
        //    }

        //    set
        //    {
        //        ViewState["Text"] = value;
        //    }
        //}

        //protected override void RenderContents(HtmlTextWriter output)
        //{
        //    output.Write(Text);
        //}




        TextBox txtSeletcedDate;
        ImageButton imgBtnCalender;
        Calendar calDate;
        [Category("Appearance")]
        [Description("Logo for the Button")]
        public string ImageUrl
        {
            get
            {
                EnsureChildControls();
                return imgBtnCalender.ImageUrl ?? string.Empty;
            }
            set
            {
                EnsureChildControls();
                imgBtnCalender.ImageUrl = value;
            }
        }

        protected override void CreateChildControls()
        {
            Controls.Clear();
            txtSeletcedDate = new TextBox();
            txtSeletcedDate.ID = "txtSelectedDate";
            txtSeletcedDate.Width = Unit.Pixel(100);

            imgBtnCalender = new ImageButton();
            imgBtnCalender.ID = "imgBtnCalender";
            imgBtnCalender.ImageUrl = ImageUrl;


            calDate = new Calendar();
            calDate.ID = "calDate";
            this.Controls.Add(txtSeletcedDate);
            this.Controls.Add(imgBtnCalender);
            this.Controls.Add(calDate);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            txtSeletcedDate.RenderControl(writer);
            imgBtnCalender.RenderControl(writer);
            calDate.RenderControl(writer);
        }
    }
}
