# Simple Event-Driven 🚀

A simple and educational project for implementing **Event-Driven Architecture** in C#. This project serves as a foundation for larger projects using event-driven patterns.

## 📋 Overview

This project implements a simple registration system using events. When a user registers (successfully or unsuccessfully), corresponding events are triggered, and the SMS service reacts to them.

## 🏗 Project Structure

```
Simple-Event-Driven/
├── Program.cs           # Main code and tests
├── UserRegister.cs      # Event publisher class
├── SmsService.cs        # Event subscriber class
└── EventArgs/           # Event data classes
    ├── UserRegisteredEventArgs.cs
    └── RegisterFailedEventArgs.cs
```

## 💡 How It Works

1. **UserRegister**: Defines and raises events
2. **SmsService**: Listens to and reacts to events
3. **EventArgs**: Carries event-related data

## 🎯 Use Cases

This project can serve as a foundation for:
- Notification Systems
- Logging and Monitoring
- Plugin-based Architectures
- Asynchronous Processing Systems

## 📝 Key Concepts

- Using `event EventHandler<T>` for event definitions
- Using `EventArgs` for data passing
- `protected virtual` pattern for raising events
- Multiple service subscription capability


## 🎓 Learning Outcomes

- Understanding event-driven architecture basics
- Implementing publisher-subscriber pattern
- Working with custom EventArgs
- Event subscription and unsubscription