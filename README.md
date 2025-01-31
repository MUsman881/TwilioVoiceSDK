<h1>📞 Twilio Voice SDK MVC Project</h1>

<p>
This project is a simple implementation of <strong>Twilio Voice SDK</strong> in an <strong>ASP.NET MVC</strong> application, 
enabling <strong>browser-to-browser</strong> calls and <strong>direct calls to phone numbers</strong>. 
It demonstrates how to integrate Twilio for handling voice communications efficiently.
</p>

<h2>🚀 Features</h2>

<ul>
  <li>📞 <strong>Browser-to-Browser Calling</strong>: Make and receive calls directly between web clients.</li>
  <li>📱 <strong>Direct Phone Calling</strong>: Call any phone number from the browser using Twilio.</li>
  <li>🔐 <strong>Secure Authentication</strong>: Uses Twilio Capability Tokens to authorize calls.</li>
  <li>🎛 <strong>Call Management</strong>: Handle call events like ringing, answering, and disconnecting.</li>
  <li>🌐 <strong>Twilio Integration</strong>: Implements Twilio's Programmable Voice API for seamless communication.</li>
</ul>
<h2>🛠 Setup Instructions</h2>

<h3>1️⃣ Prerequisites</h3>

<ul>
  <li>.NET 8 or later</li>
  <li>Twilio Account (<a href="https://www.twilio.com/try-twilio" target="_blank">Sign Up</a>)</li>
  <li>Twilio Voice SDK</li>
  <li>Ngrok (for local development)</li>
</ul>

<h3>2️⃣ Install Dependencies</h3>

<pre>
dotnet add package Twilio
</pre>

<h3>3️⃣ Configure Twilio in <code>appsettings.json</code></h3>

<pre>
{
  "TwilioAccountDetails": {
    "AccountSid": "your_account_sid",
    "AuthToken": "your_auth_token",
    "TwimlAppSid": "your_twiML_app_sid",
    "CallerId": "your_twilio_number",
    "ApiSid": "your_api_sid",
    "ApiSecret": "your_api_secret_key"
  }
}
</pre>

<h3>4️⃣ Run Your Application</h3>

<pre>
dotnet run
</pre>

Expose the local server with Ngrok:

<pre>
ngrok http https://localhost:5253
</pre>

<h2>📌 Usage</h2>

<ol>
  <li>Open the browser and go to <code>https://localhost:5001/</code></li>
  <li>Click <strong>"Call"</strong> to initiate a browser-to-browser call or dial a phone number.</li>
  <li>Accept incoming calls and communicate seamlessly.</li>
</ol>
