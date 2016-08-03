var Dict = function (code, name) {
    this.Code = ko.observable(code);
    this.Name = ko.observable(name);

}
function loadDict(url,observableArray)
{
    var getDict = $.getJSON(url).success(function (data, status, xhr) {
        var dict = [];
        $.each(data, function (i) {
            dict.push(new Dict(data[i].Code, data[i].Name));
        });
        observableArray(dict);
    })
}
function ApplicationViewModel() {
    var self = this;

    //Data
    self.citizenship = ko.observableArray();
    self.course = ko.observableArray();
    self.courseYear = ko.observableArray();
    self.gender = ko.observableArray();
    self.numberOfBed = ko.observableArray();

    self.saveCompleted = ko.observable(false);

    self.application = {
        FirstName: ko.observable(),
        Surname: ko.observable(),
        AcademicYearOfStudies: ko.observable(),
        CitizenshipDictCode: ko.observable(),
        DateOfBirth: ko.observable(),
        CourseDictKey: ko.observable(),
        GenderDictKey: ko.observable(),
        EmailAdress: ko.observable(),
        CollegeId: ko.observable(),
        IndexNumber: ko.observable(),
        CourseYearDictKey: ko.observable(),
        NumberOfBedDictKey: ko.observable()
    }


    //Loading

    var getCitizenship = loadDict("/Api/Citizenship", self.citizenship);
    var getCourse = loadDict("/Api/Course", self.course);
    var getCourseYear = loadDict("/Api/CourseYear", self.courseYear);
    var getGender = loadDict("/Api/Gender", self.gender);
    var getNumberOfBed = loadDict("/Api/NumberOfBed", self.numberOfBed);


   
}