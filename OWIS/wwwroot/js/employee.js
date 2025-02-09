$(document).ready(function () {
    // Show modal when Employee link is clicked
    $("#employeeLink").click(function () {
        $("#employeeModal").modal("show");
    });
    $('#employeeModal').on('hidden.bs.modal', function () {
        $('#employeeForm')[0].reset(); // Reset all input fields
    });
    // Fetch Employee Details on OK button click
    $("#btnFetchEmployee").click(function () {
        var empId = $("#employeeId").val();
        if (!empId) {
            alert("Please enter Employee ID");
            return;
        }

        $.ajax({
            url: "/Employee/GetEmployee",
            type: "GET",
            data: { id: empId },
            success: function (data) {
                if (data) {
                    $("#employeeName").val(data.employeeName);
                    $("#departmentName").val(data.departmentName);
                    $("#employeeSalary").val(data.employeeSalary);
                } else {
                    alert("Employee not found");
                }
            },
            error: function () {
                alert("Error fetching data");
            }
        });
    });
});
