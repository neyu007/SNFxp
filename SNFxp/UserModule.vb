Module UserModule
    Private userContext As New UsersDataClassesDataContext
    Private loggedUser As User
    Private userRole As Role
    Private currentBranch As SNFDatabaseDataSet.BranchRow

    Private groupID As Integer = 0
    Private departmentID As Integer = 0
    Private areaID As Integer = 0
    Private termID As Integer = 0
    Private truckID As Integer = 0
    Public isNewTerm As Boolean = False
    Public editTermID As Integer = -1
    Public isNewArea As Boolean = False
    Public editAreaID As Integer = -1
    Private customerID As Integer = 0
    Public isNewInvoice As Boolean = False

    Function getLoggedUser() As User

        Return loggedUser

    End Function

    Sub setLoggedUser(myLoggedUser As User)
        loggedUser = myLoggedUser
        setRole(myLoggedUser)
    End Sub

    Private Sub setRole(myUser As User)
        Dim myRole = From role In userContext.Roles _
                     Where role.RoleID.Equals(myUser.RoleID) _
                     Select role
        Try
            userRole = myRole.First
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Function getUserRole() As Role
        Return userRole
    End Function

    Sub setCurrentBranch(myBranch As SNFDatabaseDataSet.BranchRow)
        currentBranch = myBranch
    End Sub
    Function getCurrentBranch() As SNFDatabaseDataSet.BranchRow
        Return currentBranch
    End Function

    Sub setCurrentGroupID(myGroupID As Integer)
        groupID = myGroupID
    End Sub
    Function getCurrentGroupID() As Integer
        Return groupID
    End Function

    Sub setCurrentDepartmentID(myDeptID As Integer)
        departmentID = myDeptID
    End Sub
    Function getCurrentDepartmentID() As Integer
        Return departmentID
    End Function

    Sub setCurrentAreaID(myAreaID As Integer)
        areaID = myAreaID
    End Sub
    Function getCurrentAreaID() As Integer
        Return areaID
    End Function

    Sub setCurrentTermID(myTermID As Integer)
        termID = myTermID
    End Sub
    Function getCurrentTermID() As Integer
        Return termID
    End Function

    Sub setCurrentTruckID(myTruckID As Integer)
        TruckID = myTruckID
    End Sub
    Function getCurrentTruckID() As Integer
        Return truckID
    End Function

    Sub setCurrentCustomerID(myCustomerID As Integer)
        customerID = myCustomerID
    End Sub
    Function getCurrentCustomerID() As Integer
        Return customerID
    End Function
End Module
