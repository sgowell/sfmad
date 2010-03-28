var sf = {};
sf.init = function() {
    $('.siteLink').handleLookup();
    $('.ecoregionLink').handleLookup();
    //$('.standLink').handleLookup();
    $('#Date').datepicker();
};

$(function() {
  sf.init();
});

$.fn.appendSelect = function(selectItems) {
    if (!isArray(selectItems)) selectItems = [selectItems];
    var optionHtml = "";
    $.each(selectItems, function() {
        optionHtml = optionHtml + '<option value="' + this.Id + '">' + this.Name + '</option>';
    });
    $(this).append(optionHtml);
}

$.fn.reset = function() {
  $(this)
    .not(':button, :submit, :reset, :hidden')
    .val('')
    .removeAttr('checked')
    .removeAttr('selected');

}
$.fn.handleLookup = function() {
  
    var title = $(this).attr("title");
    var name = $(this).attr("name");
    var path = "/" + name + "/new";
    var allPath = "/" + name + "/all";
    
    $("." + name + "-dropdown").appendSelect({Name:"Select...", Id:0});
    
    $.post(allPath, function(data) {                
        $("." + name + "-dropdown").appendSelect(data);               
    });
    
    var d = $("<div>").attr("id", name).css('display', 'none').appendTo('body');
    $.get(path, function(data) { d.html(data); });

    var callback = function(item) {
        $.post(path, d.find('form').serialize(),
            function(data) {
                d.dialog('close');
                $("." + name + "-dropdown").appendSelect(data.Entity);
                d.find('form').reset();
            });
    };

    $(this).click(function() {
        d.dialog({
            modal: true,
            width: 500,
            buttons: { "Submit": callback }});
        $('.ui-dialog-title').text(title);
        d.dialog('open');
        
        return false;
    });

}

function isArray(obj) {
  return obj.constructor == Array;
}