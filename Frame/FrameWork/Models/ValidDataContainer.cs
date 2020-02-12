using Framework.Service;

namespace FrameWork.Models
{
    public class ValidDataContainer
    {
        public string ExistingLocation { get; set; }
        public string ValidMobilePhone { get; set; }
        public string ValidEmail { get; set; }
        public string ValidPassword { get; set; }
        public string ValidFirstName { get; set; }
        public string ValidLastName { get; set; }

        public ValidDataContainer()
        {
            ExistingLocation = ValidDataReader.GetData(ConfigKeys.ExistingLocation);
            ValidMobilePhone = ValidDataReader.GetData(ConfigKeys.ValidMobilePhone);
            ValidEmail = ValidDataReader.GetData(ConfigKeys.ValidEmail);
            ValidPassword = ValidDataReader.GetData(ConfigKeys.ValidPassword);
            ValidFirstName = ValidDataReader.GetData(ConfigKeys.ValidPassword);
            ValidLastName = ValidDataReader.GetData(ConfigKeys.ValidLastName);
        }
    }
}
