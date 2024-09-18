const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chathub")
    .build();

connection.on("ReceiveMessage", (user, message) => {
    console.log(`${user}: ${message}`);
});


connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messageList").appendChild(li);
    li.textContent = `${user} says ${message}`;
});

connection.start().then(() => {
    console.log("Connected to SignalR hub");

}).catch(err => console.error(err));


document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = "tester";
    var message = "tester3";

    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.log(err);
    });
    event.preventDefault();
})