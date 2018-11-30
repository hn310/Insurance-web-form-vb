function showExistingCompany(rbExistingCompany) {
    if (rbExistingCompany.checked == true) {
        document.getElementById("Main_ddExistingCompany").style.display = ''
        document.getElementById("Main_ExistingCompanyInfoArea").style.display = ''
        document.getElementById("Main_rbNewCompany").checked = false
        document.getElementById("Main_NewCompanyInfoArea").style.display = 'none'
    }
}

function showNewCompany(rbNewCompany) {
    if (rbNewCompany.checked == true) {
        document.getElementById("Main_NewCompanyInfoArea").style.display = ''
        document.getElementById("Main_rbExistingCompany").checked = false
        document.getElementById("Main_ddExistingCompany").style.display = 'none'
        document.getElementById("Main_ExistingCompanyInfoArea").style.display = 'none'
    }
}

