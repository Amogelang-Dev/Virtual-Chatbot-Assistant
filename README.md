# 🤖 CyberGuard AI - Cybersecurity Chatbot & Quiz

**CyberGuard AI** is a Windows-based desktop application designed to educate users on cybersecurity through an interactive chatbot and a competitive quiz system. Built using the WPF framework, it combines educational resources with a practical task-reminder system to help users stay safe online.

---

## 📖 Description
This application serves as an educational hub for cybersecurity awareness. It features a chatbot that provides expert advice on topics like phishing, password safety, and safe browsing. To reinforce learning, the app includes a quiz game where users earn points for correct answers, alongside a functional task manager that allows users to set reminders for important security-related activities.

## 🛠️ Technologies Used
* **C# & .NET 8.0:** The core programming language and framework used for backend logic and application state.
* **WPF (Windows Presentation Foundation):** Utilized for the graphical user interface, featuring a dark-themed, high-contrast design.
* **XAML:** Used to define the layout, styling, and visual structure of the application windows.
* **WPF Media Player:** Integrated to provide audio feedback and voice greetings for a more immersive user experience.

## ✨ Key Features
* **Educational Chatbot:** A keyword-based response system that answers queries about digital threats and security best practices.
* **Interactive Security Quiz:** A multiple-choice game that tracks user scores as they answer questions about topics like phishing and malware.
* **Task Reminder System:** Allows users to add specific tasks, set due dates, and track their completion status within the app.
* **User Profile Initialization:** Collects and stores a username at launch to personalize the session and track progress.
* **Audio Integration:** Features custom `.wav` greetings to engage the user upon starting the application.

## ⌨️ Navigation & Shortcuts
* **Interface Switching:** Use the UI buttons to toggle between the **Chatbot**, **Quiz**, and **History** sections.
* **Quiz Interaction:** Select options with a mouse click; selected answers are highlighted in green before submission.
* **Exit:** A dedicated "X" button is available on the landing page to safely close the application.

## 🏗️ The Build Process
1.  **Architecture:** Implemented a modular C# class structure to separate chatbot responses, user data, and reminder logic from the main UI.
2.  **UI Design:** Constructed a high-contrast black and sky-blue interface using XAML for maximum readability.
3.  **Chat Logic:** Developed a keyword extraction algorithm that splits user input and matches it against a library of security facts.
4.  **Game Mechanics:** Created a `Question` class to handle dynamic loading of quiz content and score calculation.
5.  **Persistence:** Built a `chat_history` tracker using `ArrayList` to maintain a log of the current session's interactions.

## 💡 What I Learned
* **WPF Event Handling:** Gained experience managing complex UI transitions and button clicks within a single-window application.
* **Data Organization:** Learned to use `ArrayList` and custom classes to manage dynamic data like task lists and chat responses.
* **Multimedia Integration:** Understood how to incorporate external assets like audio files and images into a compiled Windows executable.

## 🚀 Future Improvements
* **Database Integration:** Move from in-memory `ArrayLists` to a SQL database to save user scores and tasks permanently.
* **Advanced NLP:** Integrate a natural language processing library to allow the chatbot to understand more complex user intent.
* **Multi-Level Quiz:** Add difficulty settings and timed modes to the quiz for increased replayability.

---

### 🖋️ Author
* **Matlhaga Amogelang (Amo)**

---
*Project Developed for Part 3 POE*
