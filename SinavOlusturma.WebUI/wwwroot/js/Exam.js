var Exam = {
    getContentById: function (id) {
        $("#Exam_Content").val("Yükleniyor...");
        Transaction.get("\GetContentById", { id: id }, function (result) {
            $("#Exam_Content").val(result);
        });
    },

    create: function () {
        var exam = {
            Headline: $("#Exam_Headline option:selected").text(),
            Content: $("#Exam_Content").val()
        };
        var question = {
            Content: $("#Question_Content").val()
        };

        //var subjects = new Array();
        //subjects[0] = new Array("S1", "S2", "S3");
        //subjects[1] = new Array("S4", "S5", "S6");

        var selection = {
           Content: $("#Selection_Content").val()
        }


        //var selection = {
        //    A: $("#Selection_Content1").val(),
        //    B: $("#Selection_Content2").val(),
        //    C: $("#Selection_Content3").val(),
        //    D: $("#Selection_Content4").val()
        //}
        // select1 : { $("#Selection_Content1").val() };
        // select2 : { $("#Selection_Content2").val() };
        // select3 : { $("#Selection_Content3").val() };
        // select4 : { $("#Selection_Content4").val() };

        //selection.push(select1);
        //selection.push(select2);
        //selection.push(select3);
        //selection.push(select4);





        //    { "firstName": "John", "lastName": "Doe" },
        //    { "firstName": "Anna", "lastName": "Smith" },
        //    { "firstName": "Peter", "lastName": "Jones" }

        selection = JSON.stringify({ 'selection': selection });

        Transaction.post("\CreatExam", {
            exam: exam,
            question: question,
            selection: selection

        }, function (result) {
            console.log(result);
        });


    }


};



//$("#btnAdd").on("click", "[value=select]", function () {
//    $.ajax({
//        type: "Get",
//        url: "\CreatExam",
//        data: { Content: $(this).attr("selection") },
//        success: function (data) {
//            console.log(data);
//        }
//    })
//})


//$("#tab1").on("click", "[value=select]", function () {
//    $.ajax({
//        type: "Get",
//        url: "http://localhost:49600/api/Category/SelectCategory",
//        data: { CategoryID: $(this).attr("data-id"), CategoryName: $(this).attr("categoryName"), Description: $(this).attr("description") },
//        success: function (data) {
//            FethData(data);
//        }
//    })
//})

//function getContent() {
//    var id =  $("#testinyo option:selected");
//    $.ajax({
//        type: 'GET',
//        url: "\GetContentById", 
//        data: { id: id }, 
//        success: function (result) {
//            $("#Exam_Content").val(result);
//        }
//    });
//}



