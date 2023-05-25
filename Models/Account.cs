using Models.Enum;


namespace Models
{
    public class Account : CommonProperties
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? ProfileImage { get; set; }
        public string? BannerImage { get; set; }
        public string? MetaMaskAddress { get; set; }
        public AccountTypeEnum AccountType { get; set; }
        public AccountStatusEnum AccountStatus { get; set; }
        public string? AdminAccountId { get; set; }

        public string? TokenString { get; set; }
    }
}