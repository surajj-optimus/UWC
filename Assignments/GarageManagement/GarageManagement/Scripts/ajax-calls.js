// handles the click event, sends the query
function getSuccessOutput() {
	var car = {
		name: $("#name").val(),
		model: $("#model").val(),
		number: $("#number").val()
	}
	$.ajax({
		url: '/Home/CarSubmit',
		type: 'post',
		dataType: 'json',
		data: JSON.stringify(car),
		contentType: 'application/json',
		success: function (response) {
			if (response != null) {
				alert("Name : " + response.name + ", Model : " + response.model + ", Number :" + response.number);
			} else {
				alert("Something went wrong");
			}
		},
		failure: function (response) {
			alert("Something went wrong");
		},
		error: function (response) {
			alert("Something went wrong");
		}
	});
}