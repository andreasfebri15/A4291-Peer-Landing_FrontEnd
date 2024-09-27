namespace PeerLandingFE.DTO.Res
{
    public class ResMstUser
    {
        public class ResMstUserDto
        {
            public string id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string role { get; set; }
            public string jwtToken { get; set; }

        }
    }
}
