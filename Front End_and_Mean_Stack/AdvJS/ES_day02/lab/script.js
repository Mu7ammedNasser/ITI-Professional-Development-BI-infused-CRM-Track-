const usersTabs = document.getElementById("userTabs");
const postsList = document.getElementById("postsList");

fetch("https://jsonplaceholder.typicode.com/users")
  .then((res) => res.json())
  .then((users) => {
    users.forEach((user) => {
      const tab = document.createElement("div");
      tab.className = "tab";
      tab.textContent = user.username;
      usersTabs.appendChild(tab);
      tab.addEventListener("click", function () {
        console.log(user.id);
        getUserPosts(user.id);
      });
    });
  })
  .catch((err) => {
    console.error("error fetshing users", err);
  });

async function getUserPosts(userId) {
  postsList.innerHTML = "";

  try {
    const response = await fetch(
      `https://jsonplaceholder.typicode.com/posts?userId=${userId}`
    );
    const posts = await response.json();

    posts.forEach((post) => {
      const li = document.createElement("li");
      li.textContent = post.title;
      postsList.appendChild(li);
    });
  } catch (error) {
    console.error("Error fetching posts:", error);
  }
}
