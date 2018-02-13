(function ($, module) {

    module.GetByPolicyKey = function (e) {
        $.ajax(
    {
        url: config.routes.policyRoutes.getByPolicyKey,
        type: "POST",
        dataType: 'application/json',
        contentType: "text/plain",
        data: $('#customerSearchInput').val(),
        success: function (result) {
            console.log(result);
        },
        error: function (xhr, status, p3, p4) {
            var err = "Error " + " " + status + " " + p3;
            if (xhr.responseText && xhr.responseText[0] == "{")
                err = JSON.parse(xhr.responseText).message;
            console.log(err);
        }
    });
    };

}(jQuery, module = window.module || {}));