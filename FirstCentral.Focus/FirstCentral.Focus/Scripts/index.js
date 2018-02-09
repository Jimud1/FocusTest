$(function () {
    var displayCustomerSearch = () => $('#custSearchArea').load('Home/DisplayCustomerSearch');
    $('#indexGoBtn').click(displayCustomerSearch);

    var displayCustomerAdd = () => $('#custNewArea').load('Home/DisplayCustomerAdd');
    $('#indexNewBtn').click(displayCustomerAdd);
});