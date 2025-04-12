// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const AddStudent = async (student) => {
    try {
        const result = await AjaxPOST('/Student/AddStudent', student);
        if (result.success) {
            alert('Student added successfully!');
            window.location.href = "/Student/Index";
        } else {
            alert(`Failed to add student: ${result.message}`);
        }
    } catch (error) {
        console.error('Error adding student:', error);
        alert('An error occurred while adding the student.');
    }
}

const UpdateStudent = async (student) => {
    try {
        const result = await AjaxPOST('/Student/EditStudent', student);
        if (result.success) {
            alert('Student updated successfully!');
            window.location.href = "/Student/Index";
        } else {
            alert(`Failed to update student: ${result.message}`);
        }
    } catch (error) {
        console.error('Error updating student:', error);
        alert('An error occurred while updating the student.');
    }
}

const DeleteStudent = async (id) => {
    if (!confirm("Are you sure you want to delete this student?")) {
        return;
    }

    try {
        const result = await AjaxPOST('/Student/DeleteStudent', {Id: id});
        if (result.success) {
            alert('Student deleted successfully!');
            window.location.reload();
        } else {
            alert(`Failed to delete student: ${result.message}`);
        }
    } catch (error) {
        console.error('Error deleting student:', error);
        alert('An error occurred while deleting the student.');
    }
}

$(document).ready(function () {
    $('#addStudentForm').on('submit', function (e) {
        e.preventDefault();
        const student = {
            FirstName: $('#FirstName').val(),
            LastName: $('#LastName').val(),
            Age: $('#Age').val(),
            Course: $('#Course').val()
        };
        AddStudent(student);
    });

    $('#editStudentForm').on('submit', function (e) {
        e.preventDefault();
        const student = {
            Id: $('#Id').val(),
            FirstName: $('#FirstName').val(),
            LastName: $('#LastName').val(),
            Age: $('#Age').val(),
            Course: $('#Course').val()
        };
        UpdateStudent(student);
    });
});
