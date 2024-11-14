$body.on('click', '.plus-button, .minus-button', function () {
    // Get quanitity input values
    var qty = $(this).closest('.qty').find('.qty-input');
    var val = parseFloat(qty.val());
    var max = parseFloat(qty.attr('max'));
    var min = parseFloat(qty.attr('min'));
    var step = parseFloat(qty.attr('step'));

    // Check which button is clicked
    if ($(this).is('.plus-button')) {
        // Increase the value
        qty.val(val + step);
    } else {
        if (min && min >= val) {
            qty.val(min);
        } else if (val > 0) {
            qty.val(val - step);
        }
    }
});