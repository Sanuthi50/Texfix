# Texfix

# TechFix Monolithic Application (C# WinForms)

## Project Overview

TechFix is a monolithic desktop application built with C# and Windows Forms to manage quoting, inventory, and order placement processes. It serves both internal users (TechFix staff) and external supplisers, integrating multiple business functionalities into a single executable.

---

## Features

- **User Authentication:** Secure login system with role-based access (Suppliers and TechFix Users).
- **Product & Inventory Management:** Suppliers can add, update, and manage products and inventory.
- **Quotation Management:** Handling quotations including price adjustments and VAT calculations.
- **Order Placement & Management:** TechFix users place orders; suppliers can update order statuses.
- **Search & View Products:** Both user types can search and view product listings.
- **User Role Management:** Admin functions to manage users and assign roles.

---

## Technology Stack

- Programming Language: C# (.NET Framework / .NET Core)
- UI Framework: Windows Forms (WinForms)
- Database: SQL Server
- Tools: Visual Studio (IDE)

---

## Architecture

The application follows a **monolithic architecture**, where all features are combined into one executable. The entire system, including UI, business logic, and data access layers, are tightly coupled within the application.

---

## Installation

1. **Prerequisites**  
   - Windows OS  
   - Database server set up (SQL Server)

2. **Clone or Download**  
   ```bash
   git clone(https://github.com/Sanuthi50/Texfix)
   cd techfix-winforms
