var phoneUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();

var e164PhoneNumber = "+44 117 496 0123";
var phoneNumber = phoneUtil.Parse(e164PhoneNumber, null);
var result = phoneUtil.IsPossibleNumber(phoneNumber);
Console.WriteLine(result);

e164PhoneNumber = "+13212817277";
phoneNumber = phoneUtil.Parse(e164PhoneNumber, null);
result = phoneUtil.IsPossibleNumber(phoneNumber);
Console.WriteLine(result);

e164PhoneNumber = "+989302352460";
phoneNumber = phoneUtil.Parse(e164PhoneNumber, null);
result = phoneUtil.IsPossibleNumber(phoneNumber);
Console.WriteLine(result);

e164PhoneNumber = "+9893556230354";
phoneNumber = phoneUtil.Parse(e164PhoneNumber, null);
result = phoneUtil.IsPossibleNumber(phoneNumber);
Console.WriteLine(result);

e164PhoneNumber = "+98935562303";
phoneNumber = phoneUtil.Parse(e164PhoneNumber, null);
result = phoneUtil.IsPossibleNumber(phoneNumber);
Console.WriteLine(result);