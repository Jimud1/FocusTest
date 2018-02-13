$(function () {
    var displayCustomerSearch = () => $('#custSearchArea').load(config.routes.customerRoutes.displayCustomerSearch);
    $('#indexGoBtn').click(displayCustomerSearch);

    var displayCustomerAdd = () => $('#custNewArea').load(config.routes.customerRoutes.displayCustomerAdd);
    $('#indexNewBtn').click(displayCustomerAdd);
});

