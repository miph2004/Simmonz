﻿showInPopUp = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $('#form-modal .modal-body').html(res);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
        }
    })
};


jQueryAjaxPost = form => {
    try {

        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $(".view-all").html(res.html);
                    $("#form-modal .modal-body").html('');
                    $("#form-modal .modal-title").html('');
                    $("#form-modal").modal('hide');
                } else {
                    $("#form-modal .modal-body").html(res.html);
                }
            },
            error: function (err) {
                console.log(err);
            }

        })
    } catch (e) {
        console.log(e);
    }

    //to prevent default submit event
    return false;
};

jQueryAjaxDelete = form => {
    if (confirm('Bạn có muốn xóa không ?')) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    $('.view-all').html(res.html);
                },
                error: function (err) {
                    console.log(err);
                }

            })
        } catch (e) {
            console.log(e)
        }

    }
    return false;
};

jQueryAjaxCart = form => {
    try {

        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $(".view-all").html(res.html); 
                }
            },
            error: function (err) {
                console.log(err);
            }

        })
    } catch (e) {
        console.log(e);
    }

    //to prevent default submit event
    return false;
};

