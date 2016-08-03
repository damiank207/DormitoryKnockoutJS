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
function isEmpty(val){
    return (val === undefined || val == null || val.length <= 0) ? true : false;
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
    self.sending = ko.observable(false);

    self.validate = function () {
        var boolTest = true;
        var error = '<div class="alert alert-danger"><strong>Error!</strong> This field cannot be blank.</div>';
        if (isEmpty(self.application.FirstName())) {
            boolTest = false;
            $('.FirstNameValid').empty();
            $('.FirstNameValid').append(error);
        }
        else
        {
            $('.FirstNameValid').empty();
        }

        if (isEmpty(self.application.Surname())) {
            boolTest = false;
            $('.SurnameValid').empty();
            $('.SurnameValid').append(error);
        }
        else {
            $('.SurnameValid').empty();
        }

        if (isEmpty(self.application.AcademicYearOfStudies())) {
            boolTest = false;
            $('.AcademicYearOfStudiesValid').empty();
            $('.AcademicYearOfStudiesValid').append(error);
        }
        else {
            $('.AcademicYearOfStudiesValid').empty();
        }

        if (isEmpty(self.application.CitizenshipDictCode())) {
            boolTest = false;
            $('.CitizenshipDictModelIdValid').empty();
            $('.CitizenshipDictModelIdValid').append(error);
        }
        else {
            $('.CitizenshipDictModelIdValid').empty();
        }


        return false;
    };

    self.validateAndSave = function () {
        if (self.validate()) {
            $('.mySubmitButton').addClass('btn-disabled');
            $('.mySubmitButton').attr('disabled', 'disabled');
            $('.mySubmitButton').prop('disabled', true);

            self.sending(true);
            var jsonData = JSON.parse(ko.toJSON(self.application));
            $.ajax({
                url: "/Application/Create",
                data: jsonData,
                type: 'POST',
            })
            .success(self.successfulSave)
            .error(self.errorSave)
            .complete(function () { self.sending(false) });
        }
    };
    self.successfulSave = function () {
        self.saveCompleted(true);
        $('.body-content').prepend(
            '<div class="alert alert-success"><strong>Powodzenie!</strong>Nowy autor został zapisany</div>');
        setTimeout(function () {
            location.href = './';

        }, 1000);
    };
    self.errorSave = function () {
        $('.body-content').prepend(
           '<div class="alert alert-alert"><strong>Błąd!</strong>Wystąpił błąd podczas zapisywania autora</div>');
    };

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