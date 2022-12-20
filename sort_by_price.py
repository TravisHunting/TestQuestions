import json

def sort_by_price_ascending(json_string):
    # convert json string to json object
    json_object = json.loads(json_string)
    json_list_sort = list(json_object)

    # sort json_list_sort by price first, then name
    json_list_sort.sort(key=lambda x: (x['price'], x['name']))

    # stringify our list
    output = str(json_list_sort)

    # Remove spaces and replace single quotes with double quotes to fit requirements
    output = output.replace(" ", "")
    output = output.replace("\'", "\"")

    return output

print(sort_by_price_ascending('[{"name":"eggs","price":1},{"name":"coffee","price":9.99},{"name":"rice","price":4.04}]'))
# print(sort_by_price_ascending('[{"name":"eggs","price":1},{"name":"coffee","price":9.99},{"name":"rice","price":4.04},{"name":"aggs","price":1}]'))