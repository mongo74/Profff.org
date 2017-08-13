(function ($) {

    // 1. ECMA-262/5
    "use strict";

    // 2. config
    var cfg = {

        // data attributes
        data: {
            backgroundImage : "[data-backgroundImage]"

        },
        event: {
            click: "click",
            change: "change",
            load : "load"
        }
    };

    var styling = {
        init : function() {
            this.cacheItems();
            this.bindEvents();
        },    
        bindEvents: function() {
            var self = this,
                event = cfg.event;

            $(window).load(function(e) {
                self.setBackgroundImages();
            });
        },

        cacheItems : function() {
            var cache = cfg.cache;
        },

        setBackgroundImages: function () {
            $(".DynamicBG").css('background-image', function(){
                return "url(" +  $(this).data('backgroundimage') + ")";
            });
        }
    }

    //execute when page is complete
    $(document).ready(function () {
        styling.init();
    });


})(this.jQuery);