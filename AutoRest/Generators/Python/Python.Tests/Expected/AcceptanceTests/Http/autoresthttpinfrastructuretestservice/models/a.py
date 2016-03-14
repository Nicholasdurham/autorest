# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model
from msrest.exceptions import HttpOperationError


class A(Model):
    """A

    :param status_code:
    :type status_code: str
    """ 

    _attribute_map = {
        'status_code': {'key': 'statusCode', 'type': 'str'},
    }

    def __init__(self, status_code=None, **kwargs):
        self.status_code = status_code


class MyException(HttpOperationError):
    """Server responsed with exception of type: 'A'.

    :param deserialize: A deserializer
    :param response: Server response to be deserialized.
    """

    def __init__(self, deserialize, response, *args):

        super(MyException, self).__init__(deserialize, response, 'A', *args)
