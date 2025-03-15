$(document).ready(function() {
	  $(".search_blog button").click(function(){
    $("#src_blog").toggle();
});
  $('article.more').readmore({
  speed: 75,
  lessLink: '<a href="#">Show less</a>'
});
  var owl = $("#owl-demo");
 
  owl.owlCarousel({
     
      itemsCustom : [
        [0, 1],
        [450, 2],
        [600, 3],
        [700, 4],
        [1000, 5],
        [1200, 5],
        [1400, 7],
        [1600, 8]
      ],
	  autoPlay:5000,
	  pagination:false
 
  });
  
  var owl2 = $("#owl-blog");
 
  owl2.owlCarousel({
     
      itemsCustom : [
        [0, 1],
        [450, 1],
        [600, 2],
        [700, 2],
        [1000, 3],
        [1200, 4],
        [1400, 7],
        [1600, 8]
      ],
	  autoPlay:5000,
	  pagination:true
 
  });
 var sync1 = $("#sync1");
			  var sync2 = $("#sync2");
			 
			  sync1.owlCarousel({
				transitionStyle : "fade",
				singleItem : true,
				slideSpeed : 1000,
				navigation: false,
				pagination:false,
				afterAction : syncPosition,
				responsiveRefreshRate : 200,
			  });
			 
			  sync2.owlCarousel({
				items : 4,
				itemsDesktop      : [1199,4],
				itemsDesktopSmall     : [979,3],
				itemsTablet       : [768,2],
				itemsMobile       : [479,2],
				pagination:false,
				responsiveRefreshRate : 100,
				afterInit : function(el){
				  el.find(".owl-item").eq(0).addClass("synced");
				}
			  });
			 
			  function syncPosition(el){
				var current = this.currentItem;
				$("#sync2")
				  .find(".owl-item")
				  .removeClass("synced")
				  .eq(current)
				  .addClass("synced")
				if($("#sync2").data("owlCarousel") !== undefined){
				  center(current)
				}
			  }
			 
			  $("#sync2").on("click", ".owl-item", function(e){
				e.preventDefault();
				var number = $(this).data("owlItem");
				sync1.trigger("owl.goTo",number);
			  });
			 
			  function center(number){
				var sync2visible = sync2.data("owlCarousel").owl.visibleItems;
				var num = number;
				var found = false;
				for(var i in sync2visible){
				  if(num === sync2visible[i]){
					var found = true;
				  }
				}
			 
				if(found===false){
				  if(num>sync2visible[sync2visible.length-1]){
					sync2.trigger("owl.goTo", num - sync2visible.length+2)
				  }else{
					if(num - 1 === -1){
					  num = 0;
					}
					sync2.trigger("owl.goTo", num);
				  }
				} else if(num === sync2visible[sync2visible.length-1]){
				  sync2.trigger("owl.goTo", sync2visible[1])
				} else if(num === sync2visible[0]){
				  sync2.trigger("owl.goTo", num-1)
				}
				
			  }
 

});

