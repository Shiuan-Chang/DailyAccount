using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccount.Models
{
    public enum ButtonImageType
    {
        account,
        add,
        analysis,
        note,
        setting
    }

    public class GetImage
    {
        public string GetImageForUserType(ButtonImageType imageType)
        {
            switch (imageType)
            {
                case ButtonImageType.account:
                    return "Images/account.png";
                case ButtonImageType.add:
                    return "Images/add.png";
                case ButtonImageType.analysis:
                    return "Images/analysis.png";
                case ButtonImageType.note:
                    return "Images/note.png";
                case ButtonImageType.setting:
                    return "Images/setting.png";
                default:
                    return "Images/default.png";
            }
        }
    }
}
