function sendMessage() {
  const input = document.getElementById("msgInput");
  const chat = document.getElementById("chat");

  if (input.value.trim() === "") return;

  const msg = document.createElement("div");
  msg.className = "message sent";
  msg.textContent = input.value;

  chat.appendChild(msg);
  input.value = "";
  chat.scrollTop = chat.scrollHeight;

  setTimeout(() => {
    const reply = document.createElement("div");
    reply.className = "message received";
    reply.textContent = "Mensagem recebida ✔️ (demo)";
    chat.appendChild(reply);
    chat.scrollTop = chat.scrollHeight;
  }, 800);
}
