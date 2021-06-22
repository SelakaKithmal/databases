const fs = require('fs');
const faker = require('faker');

const path = 'locations_small_dupe.csv';

const header = 'Location Code,Location Name,Location Display Name,Location Type,Parent Location Code,Active Status,Test Location,Timezone,Address Line 1,Address Line 2,City,State,Zip Code,Country,Phone Number,Phone Ext.,Email,Latitude,Longitude,Location Color,Auto-Wrap Time,Show Signed in Users,Enable Wait Smarter,Allow remote check-in,Cutoff Before Closing,Check In Lead Time,Use Appointments,Future Availability Window,Appointment Cutoff Window,Summary Email Notification Time,Reminder Email Notification Time,Reminder text message notification time,Lead time for appointment booking,Concurrency Mode,Max. no of Appointments,Float Priority Mode,Change Appointemnt Status,Appointment status to change,Allow request staff,Show in widget,Use Events\n';

const users = ['buwanekas@zone24x7.com',
    'integrationuser@system.prov',
    'jituser@system.prov',
    'automationuser@system.prov',
    'kioskuser@system.prov',
    'webwidgetkuser@system.prov']

const timezones = [
'Dateline Standard Time',
'UTC-11',
'Hawaiian Standard Time',
'Alaskan Standard Time',
'Pacific Standard Time (Mexico)',
'Pacific Standard Time',
'US Mountain Standard Time',
'Mountain Standard Time (Mexico)',
'Mountain Standard Time',
'Central America Standard Time',
'Central Standard Time',
'Central Standard Time (Mexico)',
'Canada Central Standard Time',
'SA Pacific Standard Time',
'Eastern Standard Time',
'US Eastern Standard Time',
'Venezuela Standard Time',
'Paraguay Standard Time',
'Atlantic Standard Time',
'Central Brazilian Standard Time',
'SA Western Standard Time',
'Pacific SA Standard Time',
'Newfoundland Standard Time',
'E. South America Standard Time',
'Argentina Standard Time',
'SA Eastern Standard Time',
'Greenland Standard Time',
'Montevideo Standard Time',
'Bahia Standard Time',
'UTC-02',
'Mid-Atlantic Standard Time',
'Azores Standard Time',
'Cape Verde Standard Time',
'Morocco Standard Time',
'UTC',
'GMT Standard Time',
'Greenwich Standard Time',
'W. Europe Standard Time',
'Central Europe Standard Time',
'Romance Standard Time',
'Central European Standard Time',
'W. Central Africa Standard Time',
'Namibia Standard Time',
'GTB Standard Time',
'Middle East Standard Time',
'Egypt Standard Time',
'Syria Standard Time',
'E. Europe Standard Time',
'South Africa Standard Time',
'FLE Standard Time',
'Turkey Standard Time',
'Israel Standard Time',
'Jordan Standard Time',
'Arabic Standard Time',
'Kaliningrad Standard Time',
'Arab Standard Time',
'E. Africa Standard Time',
'Iran Standard Time',
'Arabian Standard Time',
'Azerbaijan Standard Time',
'Russian Standard Time',
'Mauritius Standard Time',
'Georgian Standard Time',
'Caucasus Standard Time',
'Afghanistan Standard Time',
'Pakistan Standard Time',
'West Asia Standard Time',
'India Standard Time',
'Sri Lanka Standard Time',
'Nepal Standard Time',
'Central Asia Standard Time',
'Bangladesh Standard Time',
'Ekaterinburg Standard Time',
'Myanmar Standard Time',
'SE Asia Standard Time',
'N. Central Asia Standard Time',
'China Standard Time',
'North Asia Standard Time',
'Singapore Standard Time',
'W. Australia Standard Time',
'Taipei Standard Time',
'Ulaanbaatar Standard Time',
'North Asia East Standard Time',
'Tokyo Standard Time',
'Korea Standard Time',
'Cen. Australia Standard Time',
'AUS Central Standard Time',
'E. Australia Standard Time',
'AUS Eastern Standard Time',
'West Pacific Standard Time',
'Tasmania Standard Time',
'Yakutsk Standard Time',
'Central Pacific Standard Time',
'Vladivostok Standard Time',
'New Zealand Standard Time',
'UTC+12',
'Fiji Standard Time',
'Magadan Standard Time',
'Kamchatka Standard Time',
'Tonga Standard Time',
'Samoa Standard Time',
]

const appointmentStatus = [
'Added',
'Assigned',
'Cancelled',
'Completed',
'No Show',
]

const locationTypes = [
'Holding Company',
'Organization',
'Region',
'Area',
'Branch',
'Department',
]

let lim = 500;
let lowLim = 490;

fs.appendFileSync(path, header, 'utf8', err => {
    err ? console.log(err.message) : null
});

while(lim > lowLim) {

    faker.seed(lim);

    let dataObj = new function() {
        this.LocationCode= faker.datatype.uuid(),
        this.LocationName= `${faker.random.alphaNumeric(5)}-${faker.address.cityName()}-${faker.address.citySuffix()}`,
        this.LocationDisplayName= this.LocationName,
        this.LocationType = locationTypes[Math.round(Math.random()*(locationTypes.length-1))],
        this.ParentLocationCode = "Default",
        this.ActiveStatus = Math.round(Math.random()),
        this.TestLocation = "Default",
        this.Timezone = timezones[Math.round(Math.random()*(timezones.length-1))],
        this.AddressLine1 = faker.address.streetAddress(),
        this.AddressLine2 = faker.address.secondaryAddress(),
        this.City = faker.address.city(),
        this.State = faker.address.state(),
        this.ZipCode = faker.address.zipCode(),
        this.Country = faker.address.country().substr(0,50),
        this.Phonenumber = faker.phone.phoneNumber('###-###-####'),
        this.PhoneExt = faker.datatype.number(4),
        this.Email = faker.internet.email(),
        this.Latitude = Number(faker.address.latitude()),
        this.Longitude = Number(faker.address.longitude()),
        this.LocationColor = `RGB(${faker.datatype.number(255)},${faker.datatype.number(255)},${faker.datatype.number(255)})`,
        this.AutoWrapTime = new Date(faker.time.recent()).toLocaleTimeString('en-US', {hour12: false}),
        this.ShowSignedInUsers = Math.round(Math.random()),
        this.EnableWaitSmarter = Math.round(Math.random()),
        this.AllowRemoteCheckIn = Math.round(Math.random()),
        this.CutOffBeforeClosing = new Date(faker.time.recent()).toLocaleTimeString('en-US', {hour12: false}),
        this.CheckInLeadTime = new Date(faker.time.recent()).toLocaleTimeString('en-US', {hour12: false}),
        this.UseAppointments = Math.round(Math.random()),
        this.FutureAvailabilityWindow = faker.datatype.number(100) + 1,
        this.AppointmentCutOffWindow = faker.datatype.number(100) + 1,
        this.SummaryEmailNotificationTime = new Date(faker.time.recent()).toLocaleTimeString('en-US', {hour12: false}),
        this.ReminderEmailNotificationTime = faker.datatype.number(2.0),
        this.ReminderTextMessageNotificationTime = faker.datatype.number(2.0),
        this.LeadTimeForAppointmentBooking = faker.datatype.number(2.0),
        this.ConcurrencyMode = null,
        this.MaxNumOfAppointments = faker.datatype.number(100),
        this.FloatPriorityMode = Math.round(2*Math.random() + 1),
        this.ChangeAppointmentStatus = Math.round(Math.random()),
        this.AppointmentStatusToChange = appointmentStatus[Math.round(Math.random()*(appointmentStatus.length-1))],
        this.AllowRequestStaff = Math.round(Math.random()),
        this.ShowInWidget = Math.round(Math.random()),
        this.UseEvents = Math.round(Math.random())
    }

    let data = Object.values(dataObj).map(t => `"${t}"`).join(',').concat('\n');

    fs.appendFileSync(path, data, 'utf-8', err => {
        err ? console.log(err.message) : null
    })

    lim--;
}