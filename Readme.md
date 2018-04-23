# How to implement the CustomDraw event for bar items


<p>This example demonstrates how to implement the custom draw functionality for bar items. To implement this, we created a custom BarAndDockingController descendant with the <strong>CustomDraw </strong>event.</p>
<p>This event is raised when each of bar items in <strong>BarManager </strong>is drawn and allows you to draw anything you want over the default content. Using this approach, it's easy to add the custom draw functionality to your project, because you don't even need to create a custom <strong>BarManager</strong>. Just drop our <strong>BarAndDockingController </strong>and assign it to the <strong>BarManager</strong>.<strong>Controller </strong>property.<br /><br /></p>
<p><strong>NOTE: This example is OBSOLETE starting with v14.2 since this functionality is available out of the box. Use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarManager_CustomDrawItemtopic">BarManager.CustomDrawItem</a> event.</strong></p>

<br/>


