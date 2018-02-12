$(function () {
    var displayCustomerSearch = () => $('#custSearchArea').load(config.routes.displayCustomerSearch);
    $('#indexGoBtn').click(displayCustomerSearch);

    var displayCustomerAdd = () => $('#custNewArea').load(config.routes.displayCustomerAdd);
    $('#indexNewBtn').click(displayCustomerAdd);
});