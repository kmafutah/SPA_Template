(function () {
    var root = this;





    //THIS IS FOR TESTING PURPOSES ONLY - CAN BE REMOVED:
    //***************************************************

    $().ready(function () {
        testAPI_PushModel();
    });

    function testAPI_PushModel() {
        var newModel = { Title: "This is the title for the NEW posted model." };
        $.ajax({
            type: "POST",
            url: "/api/samplemodels/",
            dataType: "json",
            data: newModel,
            success: function (d) {
                //the webapi method simply returns the (updated) model (with id set)
                console.log(d);
            },
            error: function (xhr, status, error) {
                console.log("Status: " + status + " | Error: " + error);
            }
        }).done(function () {
            console.log("Done!")
        });
    }



})();