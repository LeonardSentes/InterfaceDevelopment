@ModelType IndexViewModel
@Code
    ViewBag.Title = "Manage"
End Code

<h2>@ViewBag.Title.</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <h4>Change your account settings</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Password:</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Change your password", "ChangePassword")
            Else
                @Html.ActionLink("Create", "SetPassword")
            End If
            ]
        </dd>
        <dt>External Logins:</dt>
        <dd>
            @Model.Logins.Count [
            @Html.ActionLink("Manage", "ManageLogins") ]
        </dd>
        
        
        <dt>Two-Factor Authentication:</dt>
        <dd>
            <p>
                
            </p>
          
        </dd>
    </dl>
</div>
