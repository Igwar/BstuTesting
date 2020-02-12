using Framework.Service;

namespace FrameWork.Models
{
    public class InvalidDataContainer
    {
        public string UnavailiableLocation { get; set; }
        public string InvalidMobilePhone { get; set; }
        public string InvalidEmail { get; set; }
        public string FirstPassword { get; set; }
        public string SecondPassword { get; set; }

        public InvalidDataContainer()
        {
            UnavailiableLocation = InvalidDataReader.GetData(ConfigKeys.UnavailiableLocation);
            InvalidMobilePhone = InvalidDataReader.GetData(ConfigKeys.InvalidMobilePhone);
            InvalidEmail = InvalidDataReader.GetData(ConfigKeys.InvalidEmail);
            FirstPassword = InvalidDataReader.GetData(ConfigKeys.FirstPassword);
            SecondPassword = InvalidDataReader.GetData(ConfigKeys.SecondPassword);
        }
    }
}
