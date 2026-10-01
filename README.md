# Grocery-Checkout-Application


A Windows Forms store application written in C# (.NET) that lets a user build a shopping list from available products, apply coupons, and see the subtotal, tax, shipping, and total update automatically.

<!-- Add a screenshot of the main form here, e.g. ![Main form](screenshots/main.png) -->
Features
Product and coupon selection in separate forms, opened from the menu
Shopping list that adds the chosen item when you return to the main form
Remove button to take the selected item off the list and recalculate
Delivery checkbox that adds a shipping charge per item
Contains? combo box that checks whether an item is already on the list
Live totals for products, coupons, tax, shipping, and total, formatted as currency
Input validation with error messages when no item is selected, so the app never crashes
Products and Coupons
Product	Price
Bread	$3.95
Milk	$4.50
Sugar	$2.50
Coffee	$4.95
Coupon	Credit
Milk	-$0.75
Sugar	-$0.55
Coffee	-$1.85
How Totals Are Calculated
Value	Formula
Products	Sum of the prices of all products on the list
Coupons	Sum of the credits of all coupons on the list
Tax	Products subtotal × 6%
Shipping	$2.00 per item if Delivery is checked, otherwise $0
Total	Products + Coupons + Tax + Shipping

Tax applies only to the products subtotal, and coupons are stored as negative values, so adding them reduces the total.

Example: Bread + Milk + Milk coupon, without delivery Products $8.45, Coupons -$0.75, Tax $0.51, Shipping $0.00, Total $8.21

Menus
Menu	Item	Action
File	Reset	Clears the shopping list
File	Exit	Closes the application
Shop	Products	Opens the Products form
Shop	Coupons	Opens the Coupons form
Help	About	Shows the application name and version
How to Use
Choose Shop → Products, select an item, and click Add. The item appears on the shopping list.
Choose Shop → Coupons to add a coupon the same way.
Check Delivery if you want the order shipped.
Select an item on the list and click Remove to take it off.
Pick an item in the Contains? box to see whether it's on the list.
Use File → Reset to start over.
Project Structure
Form	Purpose
Shopping form (main)	Shopping list, delivery option, totals, menus, and the shared constants, variables, and calculation methods
Product form	Lists products; Add stores the selected name and price and closes the form, Close closes it
Coupon form	Lists coupons; same Add and Close behavior as the Product form

Controls follow standard naming prefixes (btn, lst, cbo, chk, lbl, mnu), and the app uses store.ico as its icon.

Running the Project

Requirements: Windows, Visual Studio with the .NET desktop development workload

Clone the repository.
Open the solution (.sln) file in Visual Studio.
Press F5 to build and run.
Testing

Tested to confirm that:

Every calculation matches the formulas above, with and without delivery
Adding, removing, and resetting items keeps all totals accurate
Clicking Add or Remove with nothing selected shows an error message instead of crashing
Closing the Product or Coupon form without adding anything leaves the list unchanged