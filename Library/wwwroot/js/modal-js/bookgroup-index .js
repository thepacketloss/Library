(function ($) {
    function BookGroup() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-bookgroup").on('loaded.bs.modal', function (e) {

            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new BookGroup();
        self.init();
    })
}(jQuery))
