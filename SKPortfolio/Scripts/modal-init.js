(function () {
    $('.picture-grid').on('click', '.picture-container', function () {
        modal.open({ content: $(this).html(), width: "50%" });
    });
}());