//THIS IS FOR TESTING PURPOSES ONLY - CAN BE REMOVED:
//***************************************************

define(['app/test_model'], function (tm) {
    var test = function () {
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


        //now test our dependency:
        //-------------------------
        console.log(tm.getTitle());
    };

    return {
        test: test
    };
});

