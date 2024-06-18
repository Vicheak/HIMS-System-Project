using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace HIMS.Utility
{
    internal class NotificationUtil
    {
        public static void AlertNotificationInsert()
        {
            PopupNotifier pp = new PopupNotifier();
            pp.TitleFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp.TitleText = "Save Information";
            pp.ContentFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp.ContentText = "ទិន្នន័យត្រូវបានរក្សាទុក";
            pp.BodyColor = Color.Green;
            pp.Popup();
        }

        public static void AlertNotificationEdit()
        {
            PopupNotifier pp = new PopupNotifier();
            pp.TitleFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp.TitleText = "Update Information";
            pp.ContentFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp.ContentText = "ទិន្នន័យត្រូវបានធ្វើបច្ចុប្បន្នភាព";
            pp.BodyColor = Color.Yellow;
            pp.Popup();
        }

        public static void AlertNotificationDelete()
        {
            PopupNotifier pp = new PopupNotifier();
            pp.TitleFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp.TitleText = "Delete Information";
            pp.ContentFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp.ContentText = "ទិន្នន័យត្រូវបានលុបពីប្រព័ន្ធ";
            pp.BodyColor = Color.Red;
            pp.Popup();
        }

        public static void AlertNotificationWarning(string title, string message, Color color)
        {
            PopupNotifier pp = new PopupNotifier();
            pp.TitleFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            pp.TitleText = title;
            pp.ContentFont = new Font("Khmer Kep", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); 
            pp.ContentText = message;
            pp.BodyColor = color; 
            pp.Popup(); 
        }
    }
}
