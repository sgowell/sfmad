var sf = {};
sf.init = function() {
    $('.lookupLink').handleLookup();
    $('#Date').datepicker();
};

$(function() {
  sf.init();
});

$.fn.handleLookup = function() {

    var title = $(this).attr("title");
    var name = $(this).attr("name");
    var path = "/" + name + "/new";

    var d = $("<div>").attr("id", name).css('display', 'none').appendTo('body');
    $.get(path, function(data) { d.html(data); });

    var callback = function(item) {
        $.post(path, d.find('form').serialize(),
            function(i) {
                d.dialog('close');
                var selector = "." + name + "-dropdown";

                $(selector).append($("<option></option>").
                    attr("value", i.Entity.Id).
                    text(i.Entity.Name));
            });

    };
    $(this).click(function() {
        d.dialog({
            modal: true,
            width: 500,
            buttons: { "Submit": callback }
        });
        $('.ui-dialog-title').text(title);
        d.dialog('open');
        return false;
    });

}