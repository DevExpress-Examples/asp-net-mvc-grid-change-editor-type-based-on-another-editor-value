function onTextChanged(s, e) {
    if (s.GetText() == 'newperson') {
        cbEdit.SetVisible(true);
        txtEdit.SetVisible(false);
    } else {
        cbEdit.SetVisible(false);
        txtEdit.SetVisible(true);
    }
}
function ChangeHiddenValue(s, e) { 
    var hidden = document.getElementById('LastName');
    hidden.value = cbEdit.GetVisible() ? cbEdit.GetText() : txtEdit.GetText();
}