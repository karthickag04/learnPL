namespace brightskills.Models
{
    public class UserProfileModel
    {
        public string Username { get; set; }
        public string ProfilePictureUrl { get; set; }
        // Add more properties as needed
        
        // Constructor
        public UserProfileModel(string username, string profilePictureUrl)
        {
            Username = username;
            ProfilePictureUrl = profilePictureUrl;
        }
    }
}
