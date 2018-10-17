<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
	<script>
		// handles the click event, sends the query
		function getSuccessOutput(form) {
			if ($("#name").val()===null && $("#model").val()===null && $("#number").val()===null)
			{
				form.submit();
				return false;
			}
			 var car = {
            name: $("#name").val(),
            model:$("#model").val(),
            number:$("#number").val()
			}
	$.ajax({
         url: '/Home/CarSubmit',
            type: 'post',
		dataType: 'json',
			data: JSON.stringify(car), 
            contentType: 'application/json',
		success: function(response) {  
			if (response != null) {
				alert("Name : " + response.name + ", Model : " + response.model + ", Number :" + response.number + "added");  
                    } else {  
                        alert("Something went wrong");  
                    }  
                },  
                failure: function(response) {  
                    alert("Something went wrong");  
                },  
                error: function(response) {  
                    alert(response.msg);  
                }  
			});
}

	</script>
</head>
<body>
	<h1>Add Car</h1>
<form>
<div class="panel panel-default" >
 <div class="panel-heading">
     <div class="row ">
              <div class="col-md-3 col-sm-2 col-xs-2">
                  <span class="help-block text-muted small-font" >Name:</span>
                  <input type="text" class="form-control" placeholder="Name" id="name" required/>
              </div>
         <div class="col-md-3 col-sm-3 col-xs-3">
                  <span class="help-block text-muted small-font" >Model:</span>
                  <input type="text" class="form-control" placeholder="Model" id="model" required/>
              </div>
        <div class="col-md-3 col-sm-3 col-xs-3">
                  <span class="help-block text-muted small-font" >Car No:</span>
                  <input type="text" class="form-control" placeholder="Car No." id="number" required/>
              </div>
          </div>
     <div class="row">
     </div>
	 <br />
	 <a href="#" onclick="return getSuccessOutput(this);"><input type="submit" value="Add Car"  /></a> 
     
                   </div>
              </div>
</form>
</body>
</html>