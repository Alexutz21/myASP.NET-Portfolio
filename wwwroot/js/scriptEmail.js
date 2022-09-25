function SendEmail() {
    var params = {
        from_name: document.getElementById("name").value,
        email_id: document.getElementById("email_id").value,
        phone_id: document.getElementById("phone_id").value,
        message: document.getElementById("message").value
    }
    emailjs.send("service_6c8qduj", "template_7lmpjdf", params).then
        alert("Your message was sent!");
    
}
