var phoneNumberUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();
var e164PhoneNumber = "+44 117 496 0123";
var nationalPhoneNumber = "2024561111";
var smsShortNumber = "83835";
var phoneNumber = phoneNumberUtil.Parse(e164PhoneNumber, null);
phoneNumber = phoneNumberUtil.Parse(nationalPhoneNumber, "US");
phoneNumber = phoneNumberUtil.Parse(smsShortNumber, "US");
Console.WriteLine(phoneNumber);