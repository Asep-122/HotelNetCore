var HotelToolbar = (function ($) {
	var menuaccess;

	var toolbar = {
		disableAll: function () {
			this.disableAdd();
			this.disableBack();
			this.disableCancel();
			this.disableSearch();
			this.disableDelete();
			this.disableSave();
			this.disableApproval();
		},
		enableAll: function () {
			this.enableAdd();
			this.enableBack();
			this.enableCancel();
			this.enableSearch();
			this.enableDelete();
			this.enableSave();
			this.enableApproval();
		},
		disableBack: function () {
			$("#toolbarBack").attr("disabled", "disabled").addClass("inactive");
			$("#toolbarBack").css("pointer-events", "none");
			return this;
		},
		enableBack: function () {
			$("#toolbarBack").removeAttr("disabled").removeClass("inactive");
			$("#toolbarBack").css("pointer-events", "");
			return this;
		},
		disableSearch: function () {
			$("#toolbarSearch").attr("disabled", "disabled").addClass("inactive");
			$("#toolbarSearch").css("pointer-events", "none");
			return this;
		},
		enableSearch: function () {
			$("#toolbarSearch").removeAttr("disabled").removeClass("inactive");
			$("#toolbarSearch").css("pointer-events", "");
			return this;
		},
		disableAdd: function () {
			$("#toolbarAdd").attr("disabled", "disabled").addClass("inactive");
			$("#toolbarAdd").css("pointer-events", "none");
			return this;
		},
		enableAdd: function () {
			$("#toolbarAdd").removeAttr("disabled").removeClass("inactive");
			$("#toolbarAdd").css("pointer-events", "");
			return this;
		},
		disableSave: function () {
			$("#toolbarSave").attr("disabled", "disabled").addClass("inactive");
			$("#toolbarSave").css("pointer-events", "none");
			return this;
		},
		enableSave: function () {
			$("#toolbarSave").removeAttr("disabled").removeClass("inactive");
			$("#toolbarSave").css("pointer-events", "");
			return this;
		},
		disableCancel: function () {
			$("#toolbarCancel").attr("disabled", "disabled").addClass("inactive");
			$("#toolbarCancel").css("pointer-events", "none");
			return this;
		},
		enableCancel: function () {
			$("#toolbarCancel").removeAttr("disabled").removeClass("inactive");
			$("#toolbarCancel").css("pointer-events", "");
			return this;
		},
		disableApproval: function () {
			$("#toolbarApproval").addClass("inactive");
			$("#toolbarApproval").css("pointer-events", "none");
			return this;
		},
		enableApproval: function () {
			$("#toolbarApproval").removeClass("inactive");
			$("#toolbarApproval").css("pointer-events", "");
			return this;
		},

		disableDelete: function () {
			$("#toolbarDelete").attr("disabled", "disabled").addClass("inactive");
			$("#toolbarDelete").css("pointer-events", "none");
			return this;
		},
		enableDelete: function () {
			$("#toolbarDelete").removeAttr("disabled").removeClass("inactive");
			$("#toolbarDelete").css("pointer-events", "");
			return this;
		}

	}
	return toolbar;
})($);

var astNotification = (function (astNotification) {

	astNotification.showMessage = function (message) {
		var dfd = new jQuery.Deferred();
		if (message == null) {
			message = "undefinedsda";
		}

		var dialog = $("<div></div>").dialog({
			title: "Yabes Property Web",
			modal: true,
			resizable: false,
			draggable: false,
			open: function () {
				var span = $("<span/>").addClass("ui-icon ui-icon-circle-check");
				var div = $("<div/>").text(message);
				$(this).append(span).append(div);
				//$('.ui-dialog').css('z-index', 103);
				//$('.ui-widget-overlay').css('z-index', 102);
				//console.log($(this));
			},
			close: function (event, ui) {
				$(this).dialog("destroy").remove();
			},
			buttons: {
				OK: function () {
					dfd.resolve();
					$(this).dialog("close");
				}
			}
		});
		return dfd.promise();
	}
})(astNotification || {});